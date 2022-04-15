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
        id: 101,
        title: "Air conditioner",
        desc: "LG 1 Ton 3 Star Inverter Split AC",
        salePrice: 25999,
        current_stock: 9
      },
      {
        id: 102,
        title: "Bluetooth speaker",
        desc: "iball Soundbar-B3 Speakers",
        salePrice: 1999,
        current_stock: 30
      },
      {
        id: 103,
        title: "Dvd player",
        desc: "Samsung DVD Player - DVD-E370",
        salePrice: 3999,
        current_stock: 2
      },
      {
        id: 104,
        title: "Earphones",
        desc: "Boat BassHeads 900",
        salePrice: 999,
        current_stock: 25
      },
      {
        id: 105,
        title: "Microwave",
        desc: "LG 21 litres Convection Microwave Oven",
        salePrice: 16900,
        current_stock: 5
      },
      {
        id: 106,
        title: "Refrigerator",
        desc: "Whirlpool 240 L Frost Free Triple Door",
        salePrice: 41999,
        current_stock: 12
      },
    ]
  }


  ngOnInit(): void {
  }

}
