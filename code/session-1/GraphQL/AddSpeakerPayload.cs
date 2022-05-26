namespace ConferencePlanner.GraphQL;

using ConferencePlanner.GraphQL.Data;

public class AddSpeakerPayload
{
    public AddSpeakerPayload(Speaker speaker)
    {
        Speaker = speaker;
    }

    public Speaker Speaker { get; }
}