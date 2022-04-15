import { Component, OnInit } from '@angular/core';
import { Product } from '../product';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.scss']
})
export class ProductListComponent implements OnInit {

 /* creating an object of Prodcut*/
  products: Product[];

/*Assigning values thruogh Constructor*/
  constructor() {
    this.products = [
      {
        id: 1,
        title: "Smart-Phone",
        description: "Color-black, Battery-4000mhz, Screen-16.5inch, Camera=48MPRear &1 12MP Front",
        sales_price: 10000,
        current_stock:200
      },
      {
        id: 2,
        title: "Smart-Watch",
        description: "Color-black,blue,baby-pink, Battery-upto 8hrs, Water Resistance, heart-rate-monitor",
        sales_price: 3000,
        current_stock: 50
      },
      {
        id: 3,
        title: "HeadPhone",
        description: "color-black,white,gray,neavy-blue, Battery-upto 12hrs, Water Resistance, Noise cancellation",
        sales_price: 5000,
        current_stock: 80
      },
      {
        id: 4,
        title: "Iron",
        description: "comes with 1 year warranty and electric shock protector",
        sales_price: 1500,
        current_stock: 40
      },
      {
        id: 5,
        title: "Extension Cord",
        description: "comes with multiple charging options and also protects from electrical heat",
        sales_price: 2000,
        current_stock: 150
      }
    ]
  }

  ngOnInit(): void {
  }

}
