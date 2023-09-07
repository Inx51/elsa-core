namespace Elsa.Workflows.Runtime.Requests;

public record ResumeWorkflowRuntimeOptions(
    string? CorrelationId = default,
    string? BookmarkId = default, 
    string? ActivityId = default,
    string? ActivityNodeId = default,
    string? ActivityInstanceId = default,
    string? ActivityHash = default,
    IDictionary<string, object>? Input = default);