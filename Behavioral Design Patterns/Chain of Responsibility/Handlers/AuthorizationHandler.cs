using Chain_of_Responsibility.Models;

namespace Chain_of_Responsibility.Handlers;

public class AuthorizationHandler : RequestHandler
{
    public override Response HandleRequest(Request request)
    {
        if (request.Role != "Admin")
            return new Response(false, "User not Authorized");

        return Successor != null ? Successor.HandleRequest(request) 
            : new Response(true, "User Authorized");
    }
}