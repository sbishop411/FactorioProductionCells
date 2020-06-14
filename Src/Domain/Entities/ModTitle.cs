using System;
using FactorioProductionCells.Domain.Common;
using FactorioProductionCells.Domain.Validators;

namespace FactorioProductionCells.Domain.Entities
{
    public class ModTitle : AuditableEntity
    {
        public const Int32 TitleLength = 200;
        
        private ModTitle() {}

        //public ModTitle(Guid ModId, Guid LanguageId, String Title)
        public ModTitle(Mod Mod, Guid LanguageId, String Title)
        {
            //ObjectValidator.ValidateRequiredObject(ModId, nameof(ModId));
            ObjectValidator.ValidateRequiredObject(Mod, nameof(Mod));
            ObjectValidator.ValidateRequiredObject(LanguageId, nameof(LanguageId));
            StringValidator.ValidateRequiredStringWithMaxLength(Title, nameof(Title), ModTitle.TitleLength);
            
            //this.ModId = ModId;
            this.Mod = Mod;
            this.LanguageId = LanguageId;
            this.Title = Title;
        }

        //public ModTitle(Mod Mod, Language Language, String Title) : this(Mod.Id, Language.Id, Title) {}

        public Guid ModId { get; set; }
        public Guid LanguageId { get; set; }
        public String Title { get; private set; }

        // Navigation properties
        public Mod Mod { get; private set; }
        public Language Language { get; private set; }
    }
}
