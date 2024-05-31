using System;
using System.Reflection.Metadata;

public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    // TODO: implement equality operators
    public static bool operator ==(CurrencyAmount a, CurrencyAmount b) =>
        a.currency == b.currency ? true : throw new ArgumentException();
    public static bool operator !=(CurrencyAmount a, CurrencyAmount b) =>
        a.currency != b.currency ? true : throw new ArgumentException();
    // TODO: implement comparison operators
    public static bool operator >(CurrencyAmount a, CurrencyAmount b) =>
        a == b && a.amount > b.amount;
    public static bool operator <(CurrencyAmount a, CurrencyAmount b) =>
        a == b && a.amount < b.amount;
    // TODO: implement arithmetic operators
    public static CurrencyAmount operator +(CurrencyAmount a, CurrencyAmount b) =>
        a == b ? new CurrencyAmount(a.amount + b.amount, a.currency) : throw new ArgumentException();
    public static CurrencyAmount operator -(CurrencyAmount a, CurrencyAmount b) =>
        a == b ? new CurrencyAmount(a.amount - b.amount, a.currency) : throw new ArgumentException();
    public static CurrencyAmount operator *(CurrencyAmount currencyAmount, decimal multiplier) => 
        new CurrencyAmount(currencyAmount.amount * multiplier, currencyAmount.currency);
    public static CurrencyAmount operator /(CurrencyAmount currencyAmount, decimal divider) => 
        new CurrencyAmount(currencyAmount.amount * divider, currencyAmount.currency);
    // TODO: implement type conversion operators
    public static explicit operator double(CurrencyAmount castCurrency) => (double)castCurrency.amount;
    public static implicit operator decimal(CurrencyAmount castCurrency) => castCurrency.amount;
}
