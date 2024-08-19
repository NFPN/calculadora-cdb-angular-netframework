import { Component } from '@angular/core';
import { CdbService } from '../service/CdbService';

@Component({
  selector: 'app-calcula-cdb',
  templateUrl: './calcula-cdb.component.html',
  styleUrls: ['./calcula-cdb.component.scss'],
  providers: [],
})
export class CalculaCdbComponent {
  valorInicial: string = '';
  meses: number = 1;
  isLoading: boolean = false;
  resultado: {
    valorBruto: number;
    valorLiquido: number;
    imposto: number;
  } | null = null;

  constructor(private cdbService: CdbService) {}

  validateValorInicial(value: string): boolean {
    const valorInicialNumber = parseFloat(
      value.replace(/\./g, '').replace(',', '.')
    );

    console.log(valorInicialNumber);
    console.log(isNaN(valorInicialNumber) || valorInicialNumber < 1);

    return isNaN(valorInicialNumber) || valorInicialNumber < 1;
  }

  onValorInicialChange(event: any) {
    const sanitized = event.target.value.replace(/\D/g, '');
    let numericValue = parseInt(sanitized, 10);

    if (isNaN(numericValue)) numericValue = 0;

    let formattedValue = (numericValue / 100).toFixed(2);
    formattedValue = formattedValue.replace('.', ',');
    formattedValue = formattedValue.replace(/\B(?=(\d{3})+(?!\d))/g, '.');

    this.valorInicial = formattedValue;
    event.target.value = this.valorInicial;
    console.log('changed');
  }

  onCalculate() {
    const valorInicialNumber = parseFloat(
      this.valorInicial.replace(/\./g, '').replace(',', '.')
    );

    if (isNaN(valorInicialNumber) || valorInicialNumber < 1)
      alert('Coloque um valor inicial');

    if (!this.meses || (this.meses && (this.meses < 1 || this.meses > 60)))
      alert('Coloque um valor de meses válido');

    this.isLoading = true;

    this.cdbService.calculaCDB(valorInicialNumber, this.meses).subscribe({
      next: (response) => {
        this.resultado = {
          valorBruto: response.ValorBruto,
          valorLiquido: response.ValorLiquido,
          imposto: response.Imposto,
        };

        this.isLoading = false;
      },
      error: (error) => {
        console.error('Erro ao calcular o CDB', error);
        this.isLoading = false;
      },
    });
  }
}
