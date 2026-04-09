using System;

namespace Units
{
    public readonly struct GameUnitId : IEquatable<GameUnitId>
    {
        public string Value { get; }

        public GameUnitId(string value) => Value = value ?? throw new ArgumentNullException(nameof(value));

        public bool Equals(GameUnitId other) => Value == other.Value;
        
        public override bool Equals(object obj) => obj is GameUnitId other && Equals(other);
        
        public override int GetHashCode() => Value?.GetHashCode() ?? 0;
        
        public override string ToString() => Value ?? string.Empty;
        
        public static bool operator ==(GameUnitId left, GameUnitId right) => left.Equals(right);
        public static bool operator !=(GameUnitId left, GameUnitId right) => !left.Equals(right);
    }
}