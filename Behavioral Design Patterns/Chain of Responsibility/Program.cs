// See https://aka.ms/new-console-template for more information

using Chain_of_Responsibility.Handlers;
using Chain_of_Responsibility.Models;

var handler = new AuthenticationHandler();
handler.SetNext(new AuthorizationHandler());

var request = new Request
{
    UserName = "John",
    Password = "123",
    Role = "Admin"
};

var response = handler.HandleRequest(request);

Console.WriteLine(response.Message);