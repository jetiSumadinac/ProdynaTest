using ProdynaTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProdynaTest.Core.Services.AuthorServices
{
    public interface IAuthorService
    {
        int SaveAuthor(AuthorModel data);
        bool DeleteAuthor(int id);
    }
}
