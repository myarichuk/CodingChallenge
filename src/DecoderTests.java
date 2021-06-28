import org.junit.jupiter.api.Test;

import java.security.InvalidParameterException;

import static org.junit.jupiter.api.Assertions.*;

class DecoderTests {
    @Test
    public void Will_throw_if_input_not_alphanumeric() {
        assertThrows(InvalidParameterException.class, () -> Decoder.Process("!"));
    }

    @Test
    public void Will_throw_if_input_contains_non_alphanumeric() {
        assertThrows(InvalidParameterException.class, () -> Decoder.Process("1a1b!"));
    }

    @Test
    public void Can_decode_single_tuple() {
        assertEquals("a", Decoder.Process("1a"));
    }

    @Test
    public void Can_decode_single_tuple_multiple_chars() {
        assertEquals("aaa", Decoder.Process("3a"));
    }

    @Test
    public void Can_decode_multiple_tuple_single_chars() {
        assertEquals("abc", Decoder.Process("1a1b1c"));
    }

    @Test
    public void Can_decode_multiple_tuple_multiple_chars() {
        assertEquals("aabbbc", Decoder.Process("2a3b1c"));
    }

    @Test
    public void Can_decode_multiple_tuple_multiple_chars_with_repeats() {
        assertEquals("aabbbcaaaaxbbbbbcc", Decoder.Process("2a3b1c4a1x5b2c"));
    }
}