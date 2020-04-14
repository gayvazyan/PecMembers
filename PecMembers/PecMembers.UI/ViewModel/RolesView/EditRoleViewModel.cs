using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PecMembers.UI.ViewModel.RolesView
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }

        public string Id { get; set; }

        [Required(ErrorMessage = "Մուտքագրեք Role-ի անունը ")]
        public string RoleName { get; set; }

        public List<string> Users { get; set; }
    }
}

