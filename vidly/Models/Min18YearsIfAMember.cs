using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MemberShipTypeId == MembershipType.Unknown 
                || customer.MemberShipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;
            if(customer.BirthDate==null)
                return new ValidationResult("Birth Date is required");
            var age = DateTime.Today.Year - customer.BirthDate.Value.Year;

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Must be 18 years old to be a member");

        }
    }
}