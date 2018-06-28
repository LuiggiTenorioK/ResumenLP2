/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package clienteejemplo;

/**
 *
 * @author alirapal
 */
public class ClienteEjemplo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        servicios.Ejemplo_Service service = new servicios.Ejemplo_Service();
        servicios.Ejemplo port = service.getEjemploPort();
        double suma = port.sumar(2.5,3.5);
        double resta = port.restar(4.5, 0.5);
        double multiplicacion = port.multiplicar(2.0, 3.0);
        double division = port.dividir(8.0, 2.0);
        String saludo = port.saludar("Freddy");
        System.out.println(suma);
        System.out.println(resta);
        System.out.println(multiplicacion);
        System.out.println(division);
        System.out.println(saludo);
    }
    
}
