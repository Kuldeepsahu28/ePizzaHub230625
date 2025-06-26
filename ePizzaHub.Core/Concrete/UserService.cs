using ePizzaHub.Core.Contracts;
using ePizzaHub.Models.ApiModels.Request;
using ePizzaHub.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizzaHub.Core.Concrete
{
    public class UserService : IUserService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository,
            IRoleRepository roleRepository
            )
        {
            _roleRepository = roleRepository;
            _userRepository = userRepository;
        }
        public Task<bool> CreateUserRequestAsync(CreateUserRequest createUserRequest)
        {

            var rolesDetails = _roleRepository.GetAllAsync().Where(x => x.Name == "User").FirstOrDefault();

            if (rolesDetails != null)
            {

            }

            throw new NotImplementedException();
        }
    }
}
