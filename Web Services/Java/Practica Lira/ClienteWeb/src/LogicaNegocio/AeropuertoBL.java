/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package LogicaNegocio;

/**
 *
 * @author alirapal
 */


public class AeropuertoBL {
    private servicios.ClienteWeb_Service service;
    private servicios.ClienteWeb port;
    public AeropuertoBL(){
        service = new servicios.ClienteWeb_Service();
        port = service.getClienteWebPort();
    }
}
