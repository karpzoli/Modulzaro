using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    class LanguangeFormViewModel : BaseModel1
    {
        public Language Language { get; set; }
        public bool IsNew { get; set; }

        Language language;

        public LanguangeFormViewModel(Language language)
        {
            this.Language = language;
            if (IsNew)
            {

            }
        }

        public void Save()
        {
            if (IsNew)
            {
                language = new Language
                {
                    Name = Language.Name,
                    Field = Language.Field,
                    KnowledgeLevel = Language.KnowledgeLevel
                };
            }
        }
    }
}
