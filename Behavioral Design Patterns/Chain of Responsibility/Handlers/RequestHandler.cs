using Chain_of_Responsibility.Models;

namespace Chain_of_Responsibility.Handlers;

public abstract class RequestHandler
{
    protected RequestHandler? Successor;

    public abstract Response HandleRequest(Request request);

    public void SetNext(RequestHandler successor)
    {
        Successor = successor;
    }
}