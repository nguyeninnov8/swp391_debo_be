﻿using swp391_debo_be.Constants;
using swp391_debo_be.Cores;
using swp391_debo_be.Dto.Implement;
using swp391_debo_be.Helpers;
using swp391_debo_be.Entity.Implement;
using swp391_debo_be.Services.Interfaces;
using System.Security.Cryptography;
using System.Text;
using System.Net;

namespace swp391_debo_be.Services.Implements
{
    public class UserService : IUserService
    {
        public ApiRespone CreateUser(CreateUserDto createUserDto)
        {

            if (CUser.GetUserByEmail(createUserDto.Email) != null)
            {
                return new ApiRespone { Success = false, Message = "Email is already exist", StatusCode = System.Net.HttpStatusCode.BadRequest };
            }

            User user = new User()
            {
                Id = System.Guid.NewGuid(),
                Email = createUserDto.Email,
                // Create phone number for user
                Phone = createUserDto.PhoneNumber,
                // Role = 5 la Customer -> dua tren database moi
                Role = 5,
                Password = HashPasswordHelper.HashPassword(createUserDto.password)
            };

            User createdUser = CUser.CreateUser(user);

            return new ApiRespone { Success = true, Data = createdUser, StatusCode = System.Net.HttpStatusCode.Created };
        }

        public object? GetProfile(string? userId)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            return CUser.GetUsers();
        }

        public bool IsRefreshToken(User user)
        {
            return CUser.IsRefreshTokenExist(user);
        }

        public async Task<ApiRespone> CreateNewStaff(EmployeeDto employee)
        {
            var response = new ApiRespone();
            try
            {
                if (CUser.GetUserByEmail(employee.Email) != null)
                {
                    response.StatusCode = HttpStatusCode.BadRequest;
                    response.Success = false;
                    response.Message = "Email is already exist";
                    return response;
                }
                var newStaff = await CUser.CreateNewStaff(employee);
                response.StatusCode = HttpStatusCode.OK;
                response.Success = true;
                response.Data = newStaff;
                response.Message = "Create New Staff Successfully";

            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ApiRespone> CreateNewDent(EmployeeDto employee)
        {
            var response = new ApiRespone();
            try
            {
                if (CUser.GetUserByEmail(employee.Email) != null)
                {
                    response.StatusCode = HttpStatusCode.BadRequest;
                    response.Success = false;
                    response.Message = "Email is already exist";
                    return response;
                }
                var newStaff = await CUser.CreateNewDent(employee);
                response.StatusCode = HttpStatusCode.OK;
                response.Success = true;
                response.Data = newStaff;
                response.Message = "Create New Dentist Successfully";

            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ApiRespone> CreateNewManager(EmployeeDto employee)
        {
            var response = new ApiRespone();
            try
            {
                if (CUser.GetUserByEmail(employee.Email) != null)
                {
                    response.StatusCode = HttpStatusCode.BadRequest;
                    response.Success = false;
                    response.Message = "Email is already exist";
                    return response;
                }
                var newStaff = await CUser.CreateNewManager(employee);
                response.StatusCode = HttpStatusCode.OK;
                response.Success = true;
                response.Data = newStaff;
                response.Message = "Create New Staff Successfully";

            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ApiRespone> ViewStaffList(int page, int limit)
        {
            var response = new ApiRespone();
            try
            {
                var data = await CUser.ViewStaffList(page, limit);
                response.StatusCode = HttpStatusCode.OK;
                response.Data = new { list = data, total = data.Count };
                response.Success = true;
                response.Message = "Staff list data retrieved successfully.";
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
        public async Task<ApiRespone> ViewDentList(int page, int limit)
        {
            var response = new ApiRespone();
            try
            {
                var data = await CUser.ViewDentList(page, limit);
                response.StatusCode = HttpStatusCode.OK;
                response.Data = new { list = data, total = data.Count };
                response.Success = true;
                response.Message = "Dentist list data retrieved successfully.";
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
        public async Task<ApiRespone> ViewManagerList(int page, int limit)
        {
            var response = new ApiRespone();
            try
            {
                var data = await CUser.ViewManagerList(page, limit);
                response.StatusCode = HttpStatusCode.OK;
                response.Data = new { list = data, total = data.Count };
                response.Success = true;
                response.Message = "Manager list data retrieved successfully.";
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ApiRespone> ViewCustomerList(int page, int limit)
        {
            var response = new ApiRespone();
            try
            {
                var data = await CUser.ViewCustomerList(page, limit);
                response.StatusCode = HttpStatusCode.OK;
                response.Data = new { list = data, total = data.Count };
                response.Success = true;
                response.Message = "Manager list data retrieved successfully.";
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ApiRespone> GetUserById2(Guid id)
        {
            var response = new ApiRespone();
            try
            {
                var existingUser = await CUser.GetUserById2(id);
                var role = existingUser.RoleName;
                response.StatusCode = HttpStatusCode.OK;
                response.Data = existingUser;
                response.Success = true;
                response.Message = role +" data retrieved successfully.";
            }
            catch(Exception ex)
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
