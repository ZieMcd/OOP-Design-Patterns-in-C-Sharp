using Chain_of_Responsibility.Models;

namespace Chain_of_Responsibility.Handlers;

public class AuthenticationHandler : RequestHandler
{
    public override Response HandleRequest(Request request)
    {
        if (request.Password != "123" || request.UserName != "John")
            return new Response(false, "Invalid username or password");

        return Successor != null ? Successor.HandleRequest(request) : 
            new Response(true, "Authentication Successful");
    }
}