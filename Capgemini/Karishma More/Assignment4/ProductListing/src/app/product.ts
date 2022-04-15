export class Product {

/*  defining product list variables*/
  id: number;
  title: string;
  description: string;
  sales_price: number;
  current_stock: number;

  constructor() {
    this.id = 0;
    this.title = "";
    this.description = "";
    this.sales_price = 0;
    this.current_stock = 0;
  }
}
