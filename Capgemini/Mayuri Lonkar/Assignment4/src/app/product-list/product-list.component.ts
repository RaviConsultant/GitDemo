import { Component, OnInit } from '@angular/core';
import {Product} from '../product'

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  
})
export class ProductListComponent implements OnInit {

  products: Product[];

  constructor() {
    this.products = [
      {
        id: 11 , 
        title: "TV",
        desc: "Samsung 163 cm (65 inches) Crystal 4K Series",
        salePrice: 83990,
        current_stock: 3
      },
      {
        id: 12,
        title: "Washing Machine",
        desc: "LG 5 Star Inverter  Washing Machine",
        salePrice: 37990,
        current_stock: 2
      },
      {
        id: 13,
        title: "Refrigerator",
        desc: "AmazonBasics 564 L Side-by-Side Door Refrigerator",
        salePrice: 49999,
        current_stock: 2
      },
      {
        id: 14,
        title: "Printer",
        desc: "HP Ink Tank 419 WiFi Borderless Print Colour Printer",
        salePrice: 14000,
        current_stock: 5
      },
      {
        id: 15,
        title: "Headphone",
        desc: "Sony Wh-1000Xm4 Ear Headphone ",
        salePrice: 24499,
        current_stock: 1
      },
      
    ]
  }


  ngOnInit(): void {
  }

}
