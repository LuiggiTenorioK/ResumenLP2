
package org.tempuri;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Clase Java para anonymous complex type.
 * 
 * <p>El siguiente fragmento de esquema especifica el contenido que se espera que haya en esta clase.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="listarResult" type="{http://tempuri.org/}ArrayOfAeropuerto" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "listarResult"
})
@XmlRootElement(name = "listarResponse")
public class ListarResponse {

    protected ArrayOfAeropuerto listarResult;

    /**
     * Obtiene el valor de la propiedad listarResult.
     * 
     * @return
     *     possible object is
     *     {@link ArrayOfAeropuerto }
     *     
     */
    public ArrayOfAeropuerto getListarResult() {
        return listarResult;
    }

    /**
     * Define el valor de la propiedad listarResult.
     * 
     * @param value
     *     allowed object is
     *     {@link ArrayOfAeropuerto }
     *     
     */
    public void setListarResult(ArrayOfAeropuerto value) {
        this.listarResult = value;
    }

}
