﻿namespace Dau.Services.Users
{
    public interface IUsersService
    {
        string GetFirstLastNames(string id);
        string GetFirstName(string id);
        string GetLastName(string id);
    }
}