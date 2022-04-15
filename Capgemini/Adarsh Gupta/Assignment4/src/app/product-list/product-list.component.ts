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
        title: "Laptop",
        desc: " Apple MacBook Pro",
        salePrice: 112990,
        current_stock: 4
      },
      {
        id: 12,
        title: "Mobile",
        desc: "Samsung Galaxy S22 ultra ",
        salePrice:60000,
        current_stock: 4
      },
      {
        id: 13,
        title: "Laptop",
        desc: "Dell XPS 13 laptop",
        salePrice: 117000,
        current_stock: 2
      },
      {
        id: 14,
        title: "Mobile",
        desc: "Apple iPhone 13 Pro (1TB) - Gold",
        salePrice: 169000,
        current_stock: 2
      },
      {
        id: 15,
        title: "Laptop",
        desc: "Alienware M15 R6 Gaming Laptop",
        salePrice: 239989,
        current_stock: 1
      },
      
    ]
  }


  ngOnInit(): void {
  }

}
