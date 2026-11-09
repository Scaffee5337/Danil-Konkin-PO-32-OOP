using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloadingLab;

public class AccountBalance
{
    private static int _nextId;
    public int Id { get; }
    public decimal TotalBalance { get; set; }
    public AccountBalance(decimal initialBalance)
    {
        Id = Interlocked.Increment(ref _nextId);
        TotalBalance = initialBalance;
    }
    public virtual void operator +=(decimal amount)
    {
        TotalBalance += amount;
    }
    public void operator +=(AccountBalance other)
    {
        ArgumentNullException.ThrowIfNull(other);

        TotalBalance += other.TotalBalance;
    }
    public void operator ++()
    {
        TotalBalance += 1m;
    }
    public static AccountBalance operator ++(AccountBalance a)
    {
        ArgumentNullException.ThrowIfNull(a);

        return new AccountBalance(a.TotalBalance + 1m);
    }
    public override string ToString()
    {
        return $"ID: {Id}, баланс: {TotalBalance:F2} руб.";
    }
}
