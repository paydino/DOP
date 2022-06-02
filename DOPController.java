package com.example.dopgreeting;
import java.util.concurrent.atomic.AtomicLong;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@RestController


/**
 *
 * 
 */
public class DOPController {
    private static String odgovor; 
    private final AtomicLong svi_pristigli = new AtomicLong(); 

    @GetMapping("/dopgreeting")
    public DOPService pozdrav(@RequestParam(value = "ime", defaultValue = "World") String name) {
            odgovor = "Hello, " + name + "!";
            return new DOPService(svi_pristigli.incrementAndGet(), odgovor); 
    } 
} 

