/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

/**
 *
 * @author Alvaro
 */
public class Aeropuerto {
    
    private int id;
    private String codigo;
    private String nombre;
    private String ubicacion;
    private int mts_altura;
    
    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getUbicacion() {
        return ubicacion;
    }

    public void setUbicacion(String ubicacion) {
        this.ubicacion = ubicacion;
    }

    public int getMts_altura() {
        return mts_altura;
    }

    public void setMts_altura(int mts_altura) {
        this.mts_altura = mts_altura;
    }
    
    public Aeropuerto(String Codigo,
            String Nombre, 
            String Ubicacion, 
            int Mts_altura){
        this.codigo = Codigo;
        this.mts_altura = Mts_altura;
        this.nombre = Nombre;
        this.ubicacion = Ubicacion;
    }
    public Aeropuerto(){
        
    }
}
