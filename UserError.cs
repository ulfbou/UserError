namespace UserError;

using System;

/// <summary>
/// Abstract class representing a user error.
/// </summary>
public abstract class UserError
{
    /// <summary>
    /// Gets the error message associated with the user error.
    /// </summary>
    /// <returns>The error message.</returns>
    public abstract string UEMessage();
}

/// <summary>
/// Represents an error that occurs when a numeric input is used in a text-only field.
/// </summary>
public class NumericInputError : UserError
{
    /// <summary>
    /// Gets the error message for a numeric input error.
    /// </summary>
    /// <returns>The error message.</returns>
    public override string UEMessage()
    {
        return "You tried to use a numeric input in a text-only field. This fired an error!";
    }
}

/// <summary>
/// Represents an error that occurs when a text input is used in a numeric-only field.
/// </summary>
public class TextInputError : UserError
{
    /// <summary>
    /// Gets the error message for a text input error.
    /// </summary>
    /// <returns>The error message.</returns>
    public override string UEMessage()
    {
        return "You tried to use a text input in a numeric-only field. This fired an error!";
    }
}

/// <summary>
/// Represents an error that occurs when a user attempts to perform an operation on an invalid input.
/// </summary>
public class InvalidInputError : UserError
{
    /// <summary>
    /// Gets the error message for an invalid input error.
    /// </summary>
    /// <returns>The error message.</returns>
    public override string UEMessage()
    {
        return "Oops! The input you provided is invalid. This fired an error!";
    }
}

/// <summary>
/// Represents an error that occurs when a user tries to submit a form without filling out all required fields.
/// </summary>
public class IncompleteFormError : UserError
{
    /// <summary>
    /// Gets the error message for an incomplete form error.
    /// </summary>
    /// <returns>The error message.</returns>
    public override string UEMessage()
    {
        return "Uh-oh! Looks like you forgot to fill out all required fields. This fired an error!";
    }
}

/// <summary>
/// Represents an error that occurs when a user tries to input a value that exceeds the maximum allowed length.
/// </summary>
public class MaxLengthExceededError : UserError
{
    /// <summary>
    /// Gets the error message for a maximum length exceeded error.
    /// </summary>
    /// <returns>The error message.</returns>
    public override string UEMessage()
    {
        return "Oops! The value you entered exceeds the maximum allowed length. This fired an error!";
    }
}
