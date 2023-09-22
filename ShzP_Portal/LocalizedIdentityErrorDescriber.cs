using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Extensions.Localization;
using System.ComponentModel.DataAnnotations;
using System.Resources;


    public class LocalizedIdentityErrorDescriber : IdentityErrorDescriber
    {
        private readonly ResourceManager _resourceManager;

        public LocalizedIdentityErrorDescriber(ResourceManager resourceManager)
        {
            _resourceManager = resourceManager;
        }
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError
            {
                Code = nameof(DuplicateEmail),
                Description = _resourceManager.GetString("DuplicateEmail"),
            };
        }

        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError
            {
                Code = nameof(DuplicateUserName),
                Description = _resourceManager.GetString("DuplicateUserName"),
            };
        }

        public override IdentityError InvalidEmail(string email)
        {
            return new IdentityError
            {
                Code = nameof(InvalidEmail),
                Description = _resourceManager.GetString("InvalidEmail"),
            };
        }

        public override IdentityError DuplicateRoleName(string role)
        {
            return new IdentityError
            {
                Code = nameof(DuplicateRoleName),
                Description = _resourceManager.GetString("DuplicateRoleName"),
            };
        }

        public override IdentityError InvalidRoleName(string role)
        {
            return new IdentityError
            {
                Code = nameof(InvalidRoleName),
                Description = _resourceManager.GetString("InvalidRoleName"),
            };
        }

        public override IdentityError InvalidToken()
        {
            return new IdentityError
            {
                Code = nameof(InvalidToken),
                Description = _resourceManager.GetString("InvalidToken"),
            };
        }

        public override IdentityError InvalidUserName(string userName)
        {
            return new IdentityError
            {
                Code = nameof(InvalidUserName),
                Description = _resourceManager.GetString("InvalidUserName"),
            };
        }

        public override IdentityError LoginAlreadyAssociated()
        {
            return new IdentityError
            {
                Code = nameof(LoginAlreadyAssociated),
                Description = _resourceManager.GetString("LoginAlreadyAssociated"),
            };
        }

        public override IdentityError PasswordMismatch()
        {
            return new IdentityError
            {
                Code = nameof(PasswordMismatch),
                Description = _resourceManager.GetString("PasswordMismatch"),
            };
        }

        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresDigit),
                Description = _resourceManager.GetString("PasswordRequiresDigit"),
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresLower),
                Description = _resourceManager.GetString("PasswordRequiresLower"),
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresNonAlphanumeric),
                Description = _resourceManager.GetString("PasswordRequiresNonAlphanumeric"),
            };
        }

        public override IdentityError PasswordRequiresUniqueChars(int uniqueChars)
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresUniqueChars),
                Description = _resourceManager.GetString("PasswordRequiresUniqueChars"),
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresUpper),
                Description = _resourceManager.GetString("PasswordRequiresUpper"),
            };
        }

        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = nameof(PasswordTooShort),
                Description = _resourceManager.GetString("PasswordTooShort"),
            };
        }

        public override IdentityError UserAlreadyHasPassword()
        {
            return new IdentityError
            {
                Code = nameof(UserAlreadyHasPassword),
                Description = _resourceManager.GetString("UserAlreadyHasPassword"),
            };
        }

        public override IdentityError UserAlreadyInRole(string role)
        {
            return new IdentityError
            {
                Code = nameof(UserAlreadyInRole),
                Description = _resourceManager.GetString("UserAlreadyInRole"),
            };
        }

        public override IdentityError UserNotInRole(string role)
        {
            return new IdentityError
            {
                Code = nameof(UserNotInRole),
                Description = _resourceManager.GetString("UserNotInRole"),
            };
        }

        public override IdentityError UserLockoutNotEnabled()
        {
            return new IdentityError
            {
                Code = nameof(UserLockoutNotEnabled),
                Description = _resourceManager.GetString("UserLockoutNotEnabled"),
            };
        }

        public override IdentityError RecoveryCodeRedemptionFailed()
        {
            return new IdentityError
            {
                Code = nameof(RecoveryCodeRedemptionFailed),
                Description = _resourceManager.GetString("RecoveryCodeRedemptionFailed"),
            };
        }

        public override IdentityError ConcurrencyFailure()
        {
            return new IdentityError
            {
                Code = nameof(ConcurrencyFailure),
                Description = _resourceManager.GetString("ConcurrencyFailure"),
            };
        }

        public override IdentityError DefaultError()
        {
            return new IdentityError
            {
                Code = nameof(DefaultError),
                Description = _resourceManager.GetString("DefaultIdentityError"),
            };
        }
    }


