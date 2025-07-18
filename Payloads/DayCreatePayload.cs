using Microsoft.Identity.Client;

namespace MuitaCoisaCSharp.Payload;

public record DayCreatePayload(
    List<Guid> DivasIds
);