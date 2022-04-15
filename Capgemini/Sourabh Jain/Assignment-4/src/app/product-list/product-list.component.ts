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
        id: 11 , 
        title: "Bike",
        desc: "Harley-Davidson Road king white-brown 1746cc ",
        salePrice: 2599999,
        current_stock: 4
      },
      {
        id: 12,
        title: "Car",
        desc: "Porsche 718 3900cc classic red ",
        salePrice: 15999999,
        current_stock: 2
      },
      {
        id: 13,
        title: "Car",
        desc: "Ford Mustang 4951cc Silver",
        salePrice: 7399999,
        current_stock: 2
      },
      {
        id: 14,
        title: "Bike",
        desc: "Royal Enfield Himaliya 411cc Metallic-Grey",
        salePrice: 215000,
        current_stock: 7
      },
      {
        id: 15,
        title: "Car",
        desc: "Aston Martin DBX 3982cc Auto-transmition Navy-Blue",
        salePrice: 38000000,
        current_stock: 1
      },
      
    ]
  }


  ngOnInit(): void {
  }

}
