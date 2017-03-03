using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//hints: check permissions before calling methods in objects.
//this keeps the security decoupled from the objects and enables easier testing later. 


namespace FreeErp.Administration
{
    class AdministrationSystem
    {

        public void saveUser(User user)
        {

        }

       
        public void assignRoleToUser(User user, Role role)
        {

        }

        public void deleteUser(User user)
        {

        }

        public void addRole(Role role)
        {

        }


    }

    class User
    {
        private List<Role> roles;


    }

    class Role
    {
        private List<Permission> permissions;


    }

    class Permission
    {
        public int ID { get; set}
        public string Description { get; set; }

    }
}
