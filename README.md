### UserError-bibliotek

UserError-biblioteket tillhandahåller en uppsättning klasser som representerar olika användarfel som kan uppstå under inmatningsvalidering eller formulärinsändning. Dessa fel inkapslar specifika scenarier, såsom att använda numerisk inmatning i endast textfält, försök att skicka in ett formulär med ofullständig information eller att överskrida det maximalt tillåtna värdets längd.

#### Användning

För att använda biblioteket skapar du helt enkelt instanser av de lämpliga felklasserna baserat på vilken typ av användarfel som uppstår i din applikation. Varje felklass ärver från den abstrakta bas klassen UserError, som definierar en metod för att hämta felmeddelandet för det specifika felet.

### Usage

// Exempelanvändning av UserError-klasser
var numerisktFel = new NumericInputError();
var textFel = new TextInputError();
var ogiltigtInmatningsFel = new InvalidInputError();
var ofullständigtFormulärFel = new IncompleteFormError();
var maximalLängdFel = new MaxLengthExceededError();

Console.WriteLine(numerisktFel.UEMessage());
Console.WriteLine(textFel.UEMessage());
Console.WriteLine(ogiltigtInmatningsFel.UEMessage());
Console.WriteLine(ofullständigtFormulärFel.UEMessage());
Console.WriteLine(maximalLängdFel.UEMessage());

#### Felmeddelanden

- NumericInputError: "You tried to use a numeric input in a text-only field. This fired an error!"
- TextInputError: "You tried to use a text input in a numeric-only field. This fired an error!"
- InvalidInputError: "Oops! The input you provided is invalid. This fired an error!"
- IncompleteFormError: "Uh-oh! Looks like you forgot to fill out all required fields. This fired an error!"
- MaxLengthExceededError: "Oops! The value you entered exceeds the maximum allowed length. This fired an error!"

Använd UserError-biblioteket för att hantera användarinmatningsfel på ett elegant sätt och ge meningsfull återkoppling till användarna.


------------
### UserError library

The UserError library provides a set of classes that represents various user errors that can arrise during input validation or form submits. These errors encapuslates specific scenarious, such as using numeric input in text-only fields, attempting to send an incomplete form or transgressing the maximum length of a field.

### Usage

To use this library you can simply create instances of suitable error classes based on the type of user error that occurs in your application. Each error class inherits from the abstract class UserError, which defines a method for fetching the error message for that specific error.

// Example usage of the UserError classes
var numericError = new NumericInputError();
var textError = new TextInputError();
var invalidError = new InvalidInputError();
var incompleteError = new IncompleteFormError();
var maxLengthError = new MaxLengthExceededError();

Console.WriteLine(numericError.UEMessage());
Console.WriteLine(textError.UEMessage());
Console.WriteLine(invalidError.UEMessage());
Console.WriteLine(incompleteError.UEMessage());
Console.WriteLine(maxLengthError.UEMessage());

#### Error messages

- NumericInputError: "You tried to use a numeric input in a text-only field. This fired an error!"
- TextInputError: "You tried to use a text input in a numeric-only field. This fired an error!"
- InvalidInputError: "Oops! The input you provided is invalid. This fired an error!"
- IncompleteFormError: "Uh-oh! Looks like you forgot to fill out all required fields. This fired an error!"
- MaxLengthExceededError: "Oops! The value you entered exceeds the maximum allowed length. This fired an error!"

Use the UserError library to handla user errors in a graceful way and provide useful feedback to the users. 
