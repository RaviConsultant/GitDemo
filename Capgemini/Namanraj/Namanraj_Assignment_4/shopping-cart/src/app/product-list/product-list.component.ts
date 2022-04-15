import { Component, OnInit } from '@angular/core';
import { Product } from '../product'


@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {
  products: Product[];
  constructor() {
    this.products = [
      {
        id:1,
        title: "REEBOK SHOES",
        description: "MEN'S REEBOK RUNNING IDENTITY FLEX XTREME LP SHOES",
        sale_price: 4100 ,
        current_stock: 100
      },
      {
        id:2,
        title:"PUMA x",
        description:"PUMA x one8 Virat Kohli LQDCELL Method Running Shoes" ,
        sale_price: 6999,
        current_stock: 50
      },
      {
        id:3,
        title:"Red Tape",
        description:"Red Tape Men's Rte272 Sneaker" ,
        sale_price: 1173,
        current_stock: 200
      },
    ]


  }

  ngOnInit(): void {
  }

}
