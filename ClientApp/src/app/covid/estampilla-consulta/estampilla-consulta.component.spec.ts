import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EstampillaConsultaComponent } from './estampilla-consulta.component';

describe('EstampillaConsultaComponent', () => {
  let component: EstampillaConsultaComponent;
  let fixture: ComponentFixture<EstampillaConsultaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EstampillaConsultaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EstampillaConsultaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
