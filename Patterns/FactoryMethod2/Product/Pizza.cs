﻿using System.Collections;

namespace FactoryMethod2.Product;

//Product
public abstract class Pizza
{
    public abstract string Nome { get; }
    public ArrayList Ingredientes = new ArrayList();
}
