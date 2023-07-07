//Proyecto de Programación Orientada a Objetos. José Carrillo - Clase Coche

    //Clase Coche
   class Coche {
        int Ruedas {get;set;} // Se establecen los getters y setters
        int Ancho {get;set;}
        int Largo {get;set;}
        string Motor {get;set;}
        int Peso {get;set;}
        bool AireAcondicionado {get;set;}
        bool Radio {get;set;}
        bool EsNuevo {get;set;}

        // Objeto Coche
        public Coche(
            int ruedas = 4, 
            int ancho = 2, 
            int largo = 6, 
            int peso = 800, 
            string motor = "12 Cilindros"
            ) 
        {
            this.Ruedas = ruedas;
            this.Ancho = ancho;
            this.Largo = largo;
            this.Motor = motor;
            this.Peso = peso;
        }
        public int GetRuedas() {return this.Ruedas;}
        public int GetAncho() {return this.Ancho;}
        public int GetLargo() {return this.Largo;}
        public string GetMotor() {return this.Motor;}
        public int GetPeso() {return this.Peso;}
        public void SetRuedas(int ruedas) {this.Ruedas = ruedas;}
        public void SetAncho(int ancho) {this.Ancho = ancho;}
        public void SetLargo(int largo) {this.Largo = largo;}
        public void SetMotor(string motor) {this.Motor = motor;}
        public void SetPeso(int motor) {this.Peso = peso;}
        public string GetAireAcondicionado() {
            if (this.AireAcondicionado) {
                return "El coche tiene aire acondicionado.";
            }
            return "El coche no tiene aire acondicionado.";
        }
    public void SetAireAcondicionado(string aireacondicionado = "No", bool aireacondicionadob = false){
            if (aireacondicionado.ToLower().Equals("Si") || aireacondicionadob){
                this.AireAcondicionado = true; 
            }
            this.AireAcondicionado = false;
        }

    public string GetRadio() {
            if (this.Radio){
                return "El coche tiene radio.";
            }
            return "El coche no tiene radio.";
        }

         public void SetRadio(string radio="No", bool radiob = false){
            if (radio.ToLower().Equals("Si") || radiob){
                this.AireAcondicionado = true; 
            }
            this.AireAcondicionado = false;
        }
         public string GetEsNuevo(){
            if (this.EsNuevo){
                return "El coche es nuevo.";
            }
            return "El coche no es nuevo.";
        }

         public void SetEsNuevo(string esnuevo="No", bool esnuevob = false){
            if (esnuevo.ToLower().Equals("Si") || esnuevob){
                this.EsNuevo = true; 
            }
            this.EsNuevo = false;
        }

        public int GetPrecio(){
            int PrecioBase = 5000;
            int PrecioTotal = PrecioBase;
             if (this.EsNuevo){
                PrecioTotal += 10000;
            }
            if (this.AireAcondicionado){
                PrecioTotal += 500;
            }
            if (this.Radio){
                PrecioTotal += 500;
            }

            return PrecioTotal;
        }
        public void Manejar(){
            Console.WriteLine("El coche arranca...");

        }
        public string Describir(){

            string exit = $"Este carro tiene {this.Ruedas} ruedas, y pesa {this.Peso}. Sus dimensiones son de {this.Ancho}x{this.Largo} m. Tiene el motor {this.Motor} y cuesta ${this.PrecioTotal} por sus caracteristicas.";
            Console.WriteLine(exit);
            return exit;
        }
    }
