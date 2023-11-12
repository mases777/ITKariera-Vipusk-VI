using System;
using System.Collections.Generic;
using System.Text;
public abstract class JobOffer
{
    private string jobTitle;
    public string JobTitle
    {
        get
        {
            return jobTitle;
        }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("JobTitle should be between 3 and 30 characters!");
            }
            jobTitle = value;
        }
    }
    private string company;
    public string Company
    {
        get
        {
            return company;
        }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Company should be between 3 and 30 characters!");
            }
            company = value;
        }
    }
    private double salary;
    public double Salary
    {
        get
        {
            return salary;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Salary should be 0 or positive!");
            }
            salary = value;
        }
    }
    public JobOffer(string jobTitle, string company, double salary)
    {
        JobTitle = jobTitle;
        Company = company;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"Job Title: {JobTitle}\n"
            + $"Company: {Company}\n"
            + $"Salary: {Salary:f2} BGN";
    }

}
