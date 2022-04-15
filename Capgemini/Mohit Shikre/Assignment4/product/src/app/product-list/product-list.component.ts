import { Component, OnInit } from '@angular/core';
import { Product} from '../product'
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
        id: 1,
        title: "Realme X50 Pro",
        description: "India's first 5G smartphone",
        sale_price: 43000,
        current_stock: 100
      },
      {
        id: 2,
        title: "One plus nord 5G",
        description: "Top of the Performer",
        sale_price: 29999,
        current_stock: 100
      },
      {
        id: 3,
        title: "redmi note 11 pro 5G",
        description: "smartphone come with 108 mp camera",
        sale_price: 19999,
        current_stock: 1000
      },
      {
        id: 4,
        title: "Vivo v23 Pro 5G",
        description: "Vivo's flagship smartphone ",
        sale_price: 38990,
        current_stock: 120
      }
    ]
  }

    ngOnInit(): void {
    }

  }
