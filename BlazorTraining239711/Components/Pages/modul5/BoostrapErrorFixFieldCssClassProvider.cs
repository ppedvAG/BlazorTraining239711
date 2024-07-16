using Microsoft.AspNetCore.Components.Forms;

namespace BlazorTraining239711.Components.Pages.modul5
{
    public class BoostrapErrorFixFieldCssClassProvider : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
        {
           bool isInvalid= editContext.GetValidationMessages(fieldIdentifier).Any();

            return isInvalid?"is-invalid":"is-valid";
        }
    }
}
