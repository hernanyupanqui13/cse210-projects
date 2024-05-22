using System.Text.Json;
using System.Text.Json.Serialization;

public class GoalManagerConverter : JsonConverter<GoalManager>
{
    public override bool CanConvert(Type typeToConvert)
    {
        return typeToConvert == typeof(GoalManager);
    }

    public override GoalManager Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();

        reader.Read();
        if (reader.TokenType != JsonTokenType.PropertyName)
            throw new JsonException();

        string propertyName = reader.GetString();
        if (propertyName != "_goals")
            throw new JsonException($"Unexpected property name: {propertyName}");

        reader.Read();
        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();

        List<Goal> goals = JsonSerializer.Deserialize<List<Goal>>(ref reader, options);

        reader.Read();
        if (reader.TokenType != JsonTokenType.PropertyName)
            throw new JsonException();

        propertyName = reader.GetString();
        if (propertyName != "_score")
            throw new JsonException($"Unexpected property name: {propertyName}");

        reader.Read();
        int score = reader.GetInt32();

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
            throw new JsonException();

        return new GoalManager(score, goals);
    }

    public override void Write(Utf8JsonWriter writer, GoalManager value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, typeof(GoalManager), options);
    }
}
