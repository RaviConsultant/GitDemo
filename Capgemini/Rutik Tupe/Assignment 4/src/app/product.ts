export class Product {
  id: number;
  title: string;
  descrip: string;
  salesPrice: number;
  currentstock: number;

  constructor() {
    this.id = 0;
    this.title = "";
    this.descrip = "";
    this.salesPrice = 0;
    this.currentstock = 0;
   }
}
