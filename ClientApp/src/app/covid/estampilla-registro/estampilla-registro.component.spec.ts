import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EstampillaRegistroComponent } from './estampilla-registro.component';

describe('EstampillaRegistroComponent', () => {
  let component: EstampillaRegistroComponent;
  let fixture: ComponentFixture<EstampillaRegistroComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EstampillaRegistroComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EstampillaRegistroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
