export class Product {
  id: number;
  title: string;
  description: string;
  sale_price: number;
  current_stock: number;
  constructor() {
    this.id = 0;
    this.title = "";
    this.description = "";
    this.sale_price = 0;
    this.current_stock = 0;
  }
}