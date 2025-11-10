using System;
using UnityEngine;

namespace DefaultNamespace
{
	[RequireComponent(typeof(PositionSaver))]
	public class ReplayMover : MonoBehaviour
	{
		private PositionSaver _save;

		private int _index;
		private PositionSaver.Data _prev;
		private float _duration;

		private void Start()
		{
			////todo comment: зачем нужны эти проверки?
			// Эти проверки нужны для убеждения, что компонент PositionSaver существует и содержит данные для воспроизведения
			if (!TryGetComponent(out _save) || _save.Records.Count == 0)
			{
				Debug.LogError("Records incorrect value", this);
				//todo comment: Для чего выключается этот компонент?
				// Компонент выключается, чтобы предотвратить ошибки при попытке воспроизведения пустого или отсутствующего списка записей
				enabled = false;
			}
		}

		private void Update()
		{
			var curr = _save.Records[_index];
			//todo comment: Что проверяет это условие (с какой целью)? 
			// Это условие проверяет, настало ли время для перехода к следующей точке записи, обеспечивая синхронизацию воспроизведения с временными метками
			if (Time.time > curr.Time)
			{
				_prev = curr;
				_index++;
				//todo comment: Для чего нужна эта проверка?
				// Эта проверка нужна для определения окончания воспроизведения всех записанных точек и корректного завершения работы компонента
				if (_index >= _save.Records.Count)
				{
					enabled = false;
					Debug.Log($"<b>{name}</b> finished", this);
				}
			}
			//todo comment: Для чего производятся эти вычисления (как в дальнейшем они применяются)?
			// Эти вычисления определяют коэффициент интерполяции между текущей и предыдущей точками для плавного перемещения объекта
			var delta = (Time.time - _prev.Time) / (curr.Time - _prev.Time);
			//todo comment: Зачем нужна эта проверка?
			// Эта проверка нужна для избежания ошибок при делении на ноль или других математических операциях, которые могут привести к NaN
			if (float.IsNaN(delta)) delta = 0f;
			//todo comment: Опишите, что происходит в этой строчке так подробно, насколько это возможно
			// В этой строке происходит линейная интерполяция между позицией предыдущей точки (_prev.Position) и позицией текущей точки (curr.Position) с коэффициентом delta (от 0 до 1), что создает плавное перемещение объекта между записанными точками
			transform.position = Vector3.Lerp(_prev.Position, curr.Position, delta);
		}
	}
}