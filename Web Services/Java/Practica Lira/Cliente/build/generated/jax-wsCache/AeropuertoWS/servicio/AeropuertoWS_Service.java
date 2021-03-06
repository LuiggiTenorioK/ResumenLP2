
package servicio;

import java.net.MalformedURLException;
import java.net.URL;
import javax.xml.namespace.QName;
import javax.xml.ws.Service;
import javax.xml.ws.WebEndpoint;
import javax.xml.ws.WebServiceClient;
import javax.xml.ws.WebServiceException;
import javax.xml.ws.WebServiceFeature;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.6-1b01 
 * Generated source version: 2.2
 * 
 */
@WebServiceClient(name = "AeropuertoWS", targetNamespace = "http://Servicio/", wsdlLocation = "http://localhost:8080/Servidor/AeropuertoWS?WSDL")
public class AeropuertoWS_Service
    extends Service
{

    private final static URL AEROPUERTOWS_WSDL_LOCATION;
    private final static WebServiceException AEROPUERTOWS_EXCEPTION;
    private final static QName AEROPUERTOWS_QNAME = new QName("http://Servicio/", "AeropuertoWS");

    static {
        URL url = null;
        WebServiceException e = null;
        try {
            url = new URL("http://localhost:8080/Servidor/AeropuertoWS?WSDL");
        } catch (MalformedURLException ex) {
            e = new WebServiceException(ex);
        }
        AEROPUERTOWS_WSDL_LOCATION = url;
        AEROPUERTOWS_EXCEPTION = e;
    }

    public AeropuertoWS_Service() {
        super(__getWsdlLocation(), AEROPUERTOWS_QNAME);
    }

    public AeropuertoWS_Service(WebServiceFeature... features) {
        super(__getWsdlLocation(), AEROPUERTOWS_QNAME, features);
    }

    public AeropuertoWS_Service(URL wsdlLocation) {
        super(wsdlLocation, AEROPUERTOWS_QNAME);
    }

    public AeropuertoWS_Service(URL wsdlLocation, WebServiceFeature... features) {
        super(wsdlLocation, AEROPUERTOWS_QNAME, features);
    }

    public AeropuertoWS_Service(URL wsdlLocation, QName serviceName) {
        super(wsdlLocation, serviceName);
    }

    public AeropuertoWS_Service(URL wsdlLocation, QName serviceName, WebServiceFeature... features) {
        super(wsdlLocation, serviceName, features);
    }

    /**
     * 
     * @return
     *     returns AeropuertoWS
     */
    @WebEndpoint(name = "AeropuertoWSPort")
    public AeropuertoWS getAeropuertoWSPort() {
        return super.getPort(new QName("http://Servicio/", "AeropuertoWSPort"), AeropuertoWS.class);
    }

    /**
     * 
     * @param features
     *     A list of {@link javax.xml.ws.WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns AeropuertoWS
     */
    @WebEndpoint(name = "AeropuertoWSPort")
    public AeropuertoWS getAeropuertoWSPort(WebServiceFeature... features) {
        return super.getPort(new QName("http://Servicio/", "AeropuertoWSPort"), AeropuertoWS.class, features);
    }

    private static URL __getWsdlLocation() {
        if (AEROPUERTOWS_EXCEPTION!= null) {
            throw AEROPUERTOWS_EXCEPTION;
        }
        return AEROPUERTOWS_WSDL_LOCATION;
    }

}
