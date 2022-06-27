using C4_Ejercicio2;


SmartPhone movil = new SmartPhone("Samsung", "Note 9 + ", new SistemaOperativo("Android", 9.1));
Persona persona1 = new Persona("Alejandro", "alejandromovil@gmail.com");
persona1.setSmartPhone(movil);
persona1.ActualizarSO();