import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

class EncoderTests {
    @Test
    void Can_encode_single_letter(){
        assertEquals("1a", Encoder.Process("a"));
    }

    @Test
    public void Can_encode_single_letter_group() {
        assertEquals("5a", Encoder.Process("aaaaa"));
    }

    @Test
    public void Can_encode_multiple_letter_group1() {
        assertEquals("3c5a2d4t", Encoder.Process("cccaaaaaddtttt"));
    }

    @Test
    public void Can_encode_multiple_letter_group2() {
        assertEquals("1x1y1z3c5a2d4t3a4b1a1b1a1b", Encoder.Process("xyzcccaaaaaddttttaaabbbbabab"));
    }
}