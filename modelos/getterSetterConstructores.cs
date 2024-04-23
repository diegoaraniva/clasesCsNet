public class setterGetterConsructores(){
    public string id {get; set;}
    public string propiedad {get; set;}

    public setterGetterConsructores(){

    }

    public setterGetterConsructores(int id, string propiedad){
        this.id = id;
        this.propiedad = propiedad;
    }
}