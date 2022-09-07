package cleanup

import (
	"github.com/gertd/go-pluralize"
	"log"
	"strings"
)

type irregularPlural = struct {
	single string
	plural string
}

type caseType int

const (
	LOWER caseType = iota
	UPPER
	TITLE
	CAMEL // This is likely the default in the context of TF and Azure?
)

// GetSingular return the singular version of a given plural
// return values are case preserved to the input.
func GetSingular(input string) string {
	casing := detectCasing(input)
	for _, v := range invariablePlurals() {
		if strings.EqualFold(input, v) {
			log.Printf("got %q returning %q", input, returnCased(v, casing))
			return returnCased(v, casing)
		}
	}

	for _, v := range irregularPlurals() {
		if input == v.plural {
			return v.single
		}
	}

	client := pluralize.NewClient()
	output := client.Singular(input)

	return returnCased(output, casing)
}

// GetPlural returns the plural of a given word
// return values are case preserved to the input
func GetPlural(input string) string {
	casing := detectCasing(input)
	for _, v := range invariablePlurals() {
		if strings.EqualFold(input, v) {
			return returnCased(v, casing)
		}
	}

	for _, v := range irregularPlurals() {
		if input == v.single {
			return v.plural
		}
	}

	pluralize := pluralize.NewClient()
	output := pluralize.Plural(input)

	return returnCased(output, casing)
}

// irregularPlurals is an exceptions list for plurals that are not satisfied by go-pluralize
// This list is unfortunately case sensitive for replacements due to the non-natural-language aspects of "words"
// used in service names etc
func irregularPlurals() []irregularPlural {

	pluralisationExceptions := []irregularPlural{
		{"API", "APIs"},
		{"autoscaleAPI", "autoscaleAPIs"},
		{"AutoscaleAPI", "AutoscaleAPIs"},
		{"Autoscale_API", "Autoscale_APIs"},
		{"cache", "caches"},
		{"Cache", "Caches"},
		{"sku", "skus"},
		{"Sku", "Skus"},
		{"staticCache", "staticCaches"},
		{"StaticCache", "StaticCaches"},
	}
	return pluralisationExceptions
}

// invariablePlurals is a list of words and names that should never be pluralised
func invariablePlurals() []string {
	return []string{
		"Compute",
		"ContainerInstance",
		"Cosmos-Db",
		"Data",
		"Redis",
		"Kusto",
		"PowerBIDedicated",
		"ServiceLinker",
	}
}

func detectCasing(input string) caseType {
	specialCases := []string{
		"API",
		"APIs",
		"AutoscaleAPI",
		"AutoscaleAPIs",
	}
	for _, v := range specialCases {
		if input == v {
			return CAMEL
		}
	}
	switch {
	case input == strings.ToUpper(input):
		return UPPER
	case input == strings.ToLower(input):
		return LOWER
	case input == strings.Title(input):
		return TITLE
	}
	// Fallback?
	return CAMEL
}

func returnCased(input string, casing caseType) string {
	if casing == LOWER {
		return strings.ToLower(input)
	}
	if casing == UPPER {
		return strings.ToUpper(input)
	}
	if casing == TITLE {
		return strings.Title(input)
	}

	return input
}
