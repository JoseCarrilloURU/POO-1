//Proyecto de Programación Orientada a Objetos. José Carrillo - Programa de Uso de las Clases (Main)

  class UsoCoche
    {
        static void Main(String[] args){

            //Las 6 instancias de Coche
            Coche Chevrolet = new Coche(largo: 5, ancho: 2, motor: "Ver. 2", ruedas: 4, peso: 800, radio: "No", aireacondicionado: "No", esnuevo: "No");
            Coche Toyota = new Coche(largo: 6, ancho: 3, motor: "Ver. 4", ruedas: 4, peso: 1000, radio: "Si", aireacondicionado: "Si", esnuevo: "No");
            Coche BMW = new Coche(largo: 6, ancho: 3, motor: "Ver. 6", ruedas: 4, peso: 1200, radio: "Si", aireacondicionado: "Si", esnuevo: "Si");
            Coche Ford = new Coche(largo: 6, ancho: 4, motor: "Ver. 5", ruedas: 4, peso: 800, radio: "No", aireacondicionado: "Si", esnuevo: "No");
            Coche Audi = new Coche(largo: 7, ancho: 2, motor: "Ver. 7", ruedas: 4, peso: 1300, radio: "Si", aireacondicionado: "Si", esnuevo: "Si");
            Coche Honda = new Coche(largo: 6, ancho: 3, motor: "Ver. 3", ruedas: 4, peso: 1100, radio: "Si", aireacondicionado: "Si", esnuevo: "Si");

            //Y las 6 instancias de Camioneta
            Camioneta Jeep = new Camioneta(largo: 9, ancho: 4, motor: "Ver. 7", ruedas: 4, peso: 2500, kilogramoscarga: 1500, asientosextra: 4, vidriotemplado: "No");
            Camioneta Tesla = new Camioneta(largo: 8, ancho: 4, motor: "Ver. 7", ruedas: 6, peso: 1800, kilogramoscarga: 1000, asientosextra: 2, vidriotemplado: "Si");
            Camioneta Porsche = new Camioneta(largo: 7, ancho: 4, motor: "Ver. 8", ruedas: 4, peso: 200, kilogramoscarga: 800, asientosextra: 2, vidriotemplado: "Si");
            Camioneta Chrysler = new Camioneta(largo: 8, ancho: 4, motor: "Ver. 8", ruedas: 4, peso: 2100, kilogramoscarga: 900, asientosextra: 2, vidriotemplado: "Si");
            Camioneta KIA = new Camioneta(largo: 9, ancho: 4, motor: "Ver. 6", ruedas: 4, peso: 2400, kilogramoscarga: 1100, asientosextra: 4, vidriotemplado: "No");
            Camioneta Nissan = new Camioneta(largo: 8, ancho: 4, motor: "Ver. 8", ruedas: 6, peso: 1900, kilogramoscarga: 1000, asientosextra: 2, vidriotemplado: "Si");

        }
    }