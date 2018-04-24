using MessagePack;

// don't generate formatter because not used in messagepack-object type.
public enum NoGeneratedEnum {
    Foo, Bar
}

public enum GeneratedEnum {
    Foo, Bar
}

[MessagePackObject]
public class TestObj {
    [Key( 1 )]
    public GeneratedEnum MyProperty { get; set; }
}
