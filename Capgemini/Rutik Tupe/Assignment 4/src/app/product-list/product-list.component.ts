import { Component, OnInit } from '@angular/core';
import {Product} from '../product'

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.scss']
})
export class ProductListComponent implements OnInit {

  products: Product[];

  constructor() {
    this.products = [
      {
        id: 10 , 
        title: "Laptop",
        descrip: " ASUS TUF",
        salesPrice: 85000,
        currentstock: 1
      },
      {
        id: 11,
        title: "Laptop",
        descrip: "Dell Alienware x15 ",
        salesPrice:250000,
        currentstock: 3
      },
      {
        id: 12,
        title: "Mobile",
        descrip: "Moto Edge 20 Cyan",
        salesPrice: 40000,
        currentstock: 1
      },
      {
        id: 13,
        title: "Mobile",
        descrip: "Google Pixel 6 Pro 5G",
        salesPrice: 85000,
        currentstock: 2
      },
      {
        id: 14,
        title: "Mobile",
        descrip: "Samsung Galaxy Z Flip 3 5G",
        salesPrice: 85000,
        currentstock: 6
      },
      
    ]
  }


  ngOnInit(): void {
  }

}
