using Microsoft.AspNetCore.Identity;

namespace Demo.Models
{
    public class CustomerIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = "PasswordTooShort",
                Description = "Parola en az 6 karakter olmaldır."
            };

        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Parolada en az bir büyük harf içermeldir."
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Parola en az 1 alfanumerik içermelidir."
            };
        }

    }
}
