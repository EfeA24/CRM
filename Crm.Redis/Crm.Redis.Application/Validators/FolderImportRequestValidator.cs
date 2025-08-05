using Crm.Redis.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Redis.Application.Validators
{
    public class FolderImportRequestValidator : AbstractValidator<FolderImportRequest>
    {
        public FolderImportRequestValidator()
        {
            RuleFor(x => x.FolderPath)
                .NotEmpty().WithMessage("Klasör yolu boş olamaz.")
                .Must(Directory.Exists).WithMessage("Belirtilen klasör bulunamadı.")
                .Must(IsAccessible).WithMessage("Klasöre erişilemiyor.");
        }

        private bool IsAccessible(string path)
        {
            try
            {
                _ = Directory.GetFiles(path);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
