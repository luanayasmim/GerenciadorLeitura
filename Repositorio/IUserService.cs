﻿using API_Livros.Models;
using System.Collections.Generic;

namespace API_Livros.Repositorio
{
    public interface IUserService
    {
        UserModel LookforLogin(string login);
        UserModel LookforEmail(string email, string login);
        List<UserModel> BuscarTodos();
        UserModel ListarPorId(int id);
        UserModel Adicionar(UserModel user);
        UserModel Atualizar(UserModel user);
        UserModel ChangePassword(ChangePasswordModel passwordModel);
        bool Apagar(int id);


    }
}
