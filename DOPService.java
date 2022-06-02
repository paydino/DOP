/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.example.dopgreeting;
import java.time.Duration;
import java.time.Instant;
import java.time.temporal.ChronoUnit;



public class DOPService {
    private final long requestno; 
    private final String odgovor; 
    
    private static Instant prije; 
    private static Instant sada;  

    public DOPService(long id, String content) {
            this.requestno = id;
            this.odgovor = content;
            this.sada = Instant.now(); 
    }

    public long getBrojRequesta() {
            return requestno;
    }

    public String getPozdrav() {
            return odgovor;
    }
    
    public String getDodatno() {
        String result;

        try{
            result =   "Broj sekundi od prošlog requesta: " 
                  + Duration.between(prije, sada).get(ChronoUnit.SECONDS);
        }
        catch(Exception e){

           result = "Ovo je prvi request."; 
        }

        prije = sada;  
        return result; 
    }


}

