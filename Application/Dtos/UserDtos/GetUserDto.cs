﻿namespace Application.Dtos.UserDtos
{
    public class GetUserDto
    {
        public GetUserDto() { }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
    }
}
