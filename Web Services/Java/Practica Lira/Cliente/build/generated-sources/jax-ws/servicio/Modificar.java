
package servicio;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Clase Java para modificar complex type.
 * 
 * <p>El siguiente fragmento de esquema especifica el contenido que se espera que haya en esta clase.
 * 
 * <pre>
 * &lt;complexType name="modificar">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="a" type="{http://Servicio/}aeropuerto" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "modificar", propOrder = {
    "a"
})
public class Modificar {

    protected Aeropuerto a;

    /**
     * Obtiene el valor de la propiedad a.
     * 
     * @return
     *     possible object is
     *     {@link Aeropuerto }
     *     
     */
    public Aeropuerto getA() {
        return a;
    }

    /**
     * Define el valor de la propiedad a.
     * 
     * @param value
     *     allowed object is
     *     {@link Aeropuerto }
     *     
     */
    public void setA(Aeropuerto value) {
        this.a = value;
    }

}
